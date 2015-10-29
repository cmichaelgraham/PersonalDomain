import {MapComponent} from 'maps/components/map-component';
import {Map} from 'maps/map'
// import {MapLayer} from 'maps/layers/map-layer';

export abstract class MapControl<TControl> extends MapComponent<TControl> {
	public Icon: string;
	public Description: string;
	public IsEnabled: boolean;
	public IsSelected: boolean;
	
	public constructor(map: Map<any>) {
		super(map);
	}
	
	// public abstract AddLayer<TMapLayer>(layer: (new(control: MapControl<TControl>) => MapLayer<TMapLayer>)): void;
	// public abstract RemoveLayer<TMapLayer>(layer: MapLayer<TMapLayer>): void;
}