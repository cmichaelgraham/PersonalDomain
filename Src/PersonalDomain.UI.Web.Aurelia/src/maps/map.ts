import {MapComponent} from 'maps/map-component';
import {MapControl} from 'maps/controls/map-control';

export abstract class Map<TMap> extends MapComponent<TMap> {
	public constructor() {
		super(undefined);
	}
	
	public abstract AddControl<TControl>(control: (new(map: Map<TMap>) => MapControl<TControl>)): void;
	public abstract RemoveControl<TControl>(control: MapControl<TControl>): void;
}