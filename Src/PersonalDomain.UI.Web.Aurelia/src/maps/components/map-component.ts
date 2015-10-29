export abstract class MapComponent<TComponent> {
	protected children: MapComponent<any>[] = [];
	public Component: TComponent;
	
	public constructor(protected parent: MapComponent<any>) {	
	}
	
	protected AddComponent<TChild>(component: MapComponent<TChild>): void {
		this.children.push(component);
	}
	
	protected RemoveComponent<TChild>(component: MapComponent<TChild>): void {
		this.children = this.children.filter((component) => { return component !== component; });
	}
}