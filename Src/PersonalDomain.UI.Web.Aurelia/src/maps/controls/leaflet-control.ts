import * as L from 'leaflet';
import {Map} from 'maps/map';
import {MapControl} from 'maps/controls/map-control';
// import {MapLayer} from 'maps/layers/map-layer';

export abstract class LeafletControl extends MapControl<L.IControl> {
	public ControlOptions: L.ControlOptions;
	
	public constructor(map: Map<L.Map>) {
		super(map);	
		
		this.Component = new L.Control(this.ControlOptions);
		(<any>this.Component).parent = this.parent;
		this.Component.onAdd = this.onAdd;
		(<any>this.Component).onMenuButtonClicked = this.onMenuButtonClicked;
	}
	
	// public AddLayer(layerFactory: new(control: MapControl<L.IControl>) => MapLayer<L.ILayer>): void {
	// 	var layer: MapLayer<L.ILayer> = new layerFactory(this);
	// 	(<Map<L.Map>>this.parent).Component.addLayer(layer.Component);
	// 	super.AddComponent(layer);		
	// }

	public onAdd(map: L.Map) {
		var container = L.DomUtil.create('div', 'leaflet-bar leaflet-control');	
		
		var button = L.DomUtil.create('a', "", container);
		button.innerHTML = "<i class='fa-crosshairs fa fa-lg'></i>";
		(<any>button).href = "#";
		button.title = "Menu Button";
		
		L.DomEvent.on(button, 'click', L.DomEvent.stopPropagation)
				  .on(button, 'mousedown', L.DomEvent.stopPropagation)
				  .on(button, 'dblclick', L.DomEvent.stopPropagation)
				  .on(button, 'click', L.DomEvent.preventDefault)
				  .on(button, 'click', this.onMenuButtonClicked, this);
				  
		return container;
	} 
	
	public abstract onMenuButtonClicked(e: Event) : void;
	
	// public RemoveLayer(layer: MapLayer<L.ILayer>): void {
	// 	(<Map<L.Map>>this.parent).Component.removeLayer(layer.Component);
	// 	super.RemoveComponent(layer);	
	// }		
}