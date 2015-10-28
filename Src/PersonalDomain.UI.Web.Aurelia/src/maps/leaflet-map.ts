import * as L from 'leaflet';
import {Map} from 'maps/map';
import {MapControl} from 'maps/controls/map-control';

import {ZoomToLocationControl} from 'maps/controls/zoom-to-location/zoom-to-location-control';

export class LeafletMap extends Map<L.Map> {
	public constructor() {
		super();
	}
	
	public attached() {
		this.Component = L.map('map').setView([51.505, -0.09], 13);
		L.tileLayer('http://{s}.tile.osm.org/{z}/{x}/{y}.png', { attribution: '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'}).addTo(this.Component);
		this.AddControl(ZoomToLocationControl);
	}
	
	public AddControl(controlFactory: new(map: Map<L.Map>) => MapControl<L.IControl>) {
		var control: MapControl<L.IControl> = new controlFactory(this);
		this.Component.addControl(control.Component);
		super.AddComponent(control);
	}
	
	public RemoveControl(control: MapControl<L.IControl>) {
		this.Component.removeControl(control.Component);
		super.RemoveComponent(control);
	}
}