var gulp = require('gulp');
var bundler = require('aurelia-bundler').bundle;

var config = {
	force: true,
	packagePath: '.',
	bundles: {
		"dist/app-build": {
			includes: [
				'**/*',
				'**/*.html!text',
				'**/*.css!text',			
			],
			options: { inject: true, minify: true }
		},
		"dist/aurelia": {
			includes: [
				"aurelia-bootstrapper",
      			"aurelia-computed",			  
      			"aurelia-framework",
				"github:aurelia/history-browser",				  
				"aurelia-http-client",
				"github:aurelia/loader-default",
				"github:aurelia/templating-binding",
				"github:aurelia/templating-resources",
				"github:aurelia/templating-router",									
			],
			options: { force: true, inject: true }
		}		
	}
};

gulp.task('bundle', function() {  
  return bundler(config);
});