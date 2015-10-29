import * as L from 'leaflet';
import {Map} from 'maps/map';
import {MapControl} from 'maps/controls/map-control';
import {MapLayer} from 'maps/layers/map-layer';

export abstract class LeafletControl extends MapControl<L.IControl> {
	public abstract ControlOptions(): L.ControlOptions;
	
	public constructor(map: Map<L.Map>) {
		super(map);
		
		//jpc- TODO: Find a more elegant way to extend the Leaflet Control
		//			 to contain additional properties from the derived class
		this.Component = new L.Control(this.ControlOptions());
		(<any>this.Component).parent = this.parent;
		(<any>this.Component).children = this.children;
		(<any>this.Component).Icon = this.Icon;
		(<any>this.Component).Description = this.Description;
		this.Component.onAdd = this.onAdd;
		(<any>this.Component).onMenuButtonClicked = this.onMenuButtonClicked;
	}
	
	public AddLayer(layerFactory: new(control: MapControl<L.IControl>) => MapLayer<L.ILayer>): void {
		var layer: MapLayer<L.ILayer> = new layerFactory(this);
		(<Map<L.Map>>this.parent).Component.addLayer(layer.Component);
		super.AddComponent(layer);		
	}

	public onAdd(map: L.Map) {
		var container = L.DomUtil.create('div', 'leaflet-bar leaflet-control');	
		
		var button = L.DomUtil.create('a', "", container);
		button.innerHTML = "<i class='" + this.Icon() + " fa fa-lg'></i>";
		(<any>button).href = "#";
		button.title = this.Description();
		
		L.DomEvent.on(button, 'click', L.DomEvent.stopPropagation)
				  .on(button, 'mousedown', L.DomEvent.stopPropagation)
				  .on(button, 'dblclick', L.DomEvent.stopPropagation)
				  .on(button, 'click', L.DomEvent.preventDefault)
				  .on(button, 'click', this.onMenuButtonClicked, this);
				  
		return container;
	} 
	
	public abstract onMenuButtonClicked(e: Event) : void;
	
	public RemoveLayer(layer: MapLayer<L.ILayer>): void {
		(<Map<L.Map>>this.parent).Component.removeLayer(layer.Component);
		super.RemoveComponent(layer);	
	}		
}