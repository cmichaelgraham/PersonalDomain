var gulp = require('gulp');
var bundler = require('aurelia-bundler').bundle;

var config = {
	force: true,
	packagePath: '.',
	bundles: {
		"dist/app-build": {
			includes: [
				'*/**/*',
				'*/**/*.html!text',
				'*/**/*.css!text'
			],
      		excludes: [
				'npm:*',				  
        		'github:*'
      		],			
			options: {
				force: true,
				inject: true,
				minify: true,
				mangle: true
			}
		},
		"dist/aurelia": {
			includes: [
				"aurelia-bootstrapper",
      			"aurelia-computed",
      			"aurelia-framework",
				"aurelia-http-client"				
			],
			options: {
				force: true,
				inject: true,
				minify: true,
				mangle: true				
			}
		}		
	}
};

gulp.task('bundle', function() {  
  return bundler(config);
});