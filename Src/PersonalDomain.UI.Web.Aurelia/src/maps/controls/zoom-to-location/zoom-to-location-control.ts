import {LeafletControl} from 'maps/controls/leaflet-control';
import * as L from 'leaflet';
import {Map} from 'maps/map';

export class ZoomToLocationControl extends LeafletControl {
	public ControlOptions: L.ControlOptions = [{ position: 'topleft' }];
	public Icon: string = "fa-crosshairs";
	public Description: string = "Description of the Control";
	
	public constructor(map: Map<L.Map>) {
		super(map);	
	}
		
	public onMenuButtonClicked(e: Event) : void {
		(<L.Map>this.parent.Component).setView([38.93778133670863, -77.34272003173828], 8, { reset: false, animate: true, pan: { duration: 0.75 } });	
	}
}