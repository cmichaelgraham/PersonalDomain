import {MapComponent} from 'maps/components/map-component';
import {MapControl} from 'maps/controls/map-control';

export abstract class MapLayer<TLayer> extends MapComponent<TLayer> {
	public constructor(control: MapControl<any>) {
		super(control);
	}
}