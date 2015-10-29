import * as L from 'leaflet';
import {MapControl} from 'maps/controls/map-control';
import {MapLayer} from 'maps/layers/map-layer';

export abstract class LeafletLayer extends MapLayer<L.ILayer> {
	public constructor(control: MapControl<L.IControl>) {
		super(control);	
	}		
}