// import {MapComponent} from 'maps/map-component';
// import {MapControl} from 'maps/controls/map-control';
// import {MapMarker} from 'maps/markers/map-marker';
// import {MapVector} from 'maps/vectors/map-vector';
// import {MapPopup} from 'maps/popups/map-popup';
// 
// export abstract class MapLayer<TLayer> extends MapComponent<TLayer> {
// 	public constructor(control: MapControl<any>, markers: MapMarker<any>[], vectors: MapVector<any>[], popups: MapPopup<any>[]) {
// 		super(control, markers.concat(vectors).concat(popups));
// 	}
// 	
// 	public abstract AddMarker<TMarker>(marker: MapMarker<TMarker>): void;
// 	public abstract RemoveMarker<TMarker>(marker: MapMarker<TMarker>): void;
// 	
// 	public abstract AddVector<TVector>(vector: MapVector<TVector>): void;
// 	public abstract RemoveVector<TVector>(vector: MapVector<TVector>): void;
// 	
// 	public abstract AddPopup<TPopup>(popup: MapPopup<TPopup>): void;
// 	public abstract RemovePopup<TPopup>(popup: MapPopup<TPopup>): void;	
// }