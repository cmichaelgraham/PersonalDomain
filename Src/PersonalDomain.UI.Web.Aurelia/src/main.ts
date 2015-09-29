export function configure(aurelia) {
	aurelia.use	
	   .standardConfiguration()
	   .developmentLogging()
	   .plugin('aurelia-computed')
	   .plugin('aurelia-validation');
	   
	aurelia.start().then(a => a.setRoot('shell', document.body));
}