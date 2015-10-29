import {MapComponent} from 'maps/components/map-component';
import {Map} from 'maps/map'
import {MapLayer} from 'maps/layers/map-layer';

export abstract class MapControl<TControl> extends MapComponent<TControl> {
	public abstract Icon(): string;
	public abstract Description(): string;
	public abstract IsEnabled(): boolean;
	public abstract IsSelected(): boolean;
	
	public constructor(map: Map<any>) {
		super(map);
	}
	
	public abstract AddLayer<TMapLayer>(layer: (new(control: MapControl<TControl>) => MapLayer<TMapLayer>)): void;
	public abstract RemoveLayer<TMapLayer>(layer: MapLayer<TMapLayer>): void;
}