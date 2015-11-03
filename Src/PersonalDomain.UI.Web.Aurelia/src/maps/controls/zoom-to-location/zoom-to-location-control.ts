import {LeafletControl} from 'maps/controls/leaflet-control';
import * as L from 'leaflet';
import {Map} from 'maps/map';

export class ZoomToLocationControl extends LeafletControl {
	public ControlOptions(): L.ControlOptions { return [{ position: 'topleft' }]; }
	public Icon(): string { return "fa-crosshairs"; }
	public Description(): string { return "Description of the Control"; }
	public IsEnabled(): boolean { return true; }
	public IsSelected(): boolean { return true; }

	public constructor(map: Map<L.Map>) {	
		super(map);	
	}
		
	public onMenuButtonClicked(e: Event) : void {
		var coordinates = [38.93778133670863, -77.34272003173828];
		(<L.Map>this.parent.Component).setView(coordinates, 8, { reset: false, animate: true, pan: { duration: 0.75 } });
			
		var geoJson = {
			'type': 'FeatureCollection',
			'features': [{  'type': 'Feature', 'geometry': { 'type': 'Point', 'coordinates': coordinates } }]
		};
		
		var geoJsonLayer = L.geoJson(geoJson);		
	}
}