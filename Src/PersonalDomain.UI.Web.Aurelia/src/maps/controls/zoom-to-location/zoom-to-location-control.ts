import {LeafletControl} from 'maps/controls/leaflet-control';

export class ZoomToLocationControl extends LeafletControl {
	public ControlOptions: L.ControlOptions = [{ position: 'topleft' }];
	public Icon: string = "fa-crosshairs";
	public Description: string = "Description of the Control";
}