var assign = Object.assign || require('object.assign');
var babelOptions = require('../babel-options');
var changed = require('gulp-changed');
var gulp = require('gulp');
var paths = require('../paths');
var plumber = require('gulp-plumber');
var runSequence = require('run-sequence');
var sourcemaps = require('gulp-sourcemaps');
var to5 = require('gulp-babel');
var typescript = require('gulp-typescript');
var tsconfigGlob = require('tsconfig-glob');
var tsc = require('typescript');

var tsProject = typescript.createProject('./tsconfig.json', { typescript: tsc });

gulp.task('expand-tsconfig-globs', function(done) {
    tsconfigGlob({
      configPath: '.',
      cwd: process.cwd(),
      indent: 2
    }, done);
});

gulp.task('build-system', function () {
  return tsProject.src()
    .pipe(typescript(tsProject))  
    .pipe(plumber())
    .pipe(changed(paths.output, {extension: '.js'}))
    .pipe(sourcemaps.init({loadMaps: true}))
    .pipe(to5(assign({}, babelOptions, {modules:'system'})))
    .pipe(sourcemaps.write({includeContent: true}))
    .pipe(gulp.dest(paths.output));
});

gulp.task('build-html', function () {
  return gulp.src(paths.html)
    .pipe(changed(paths.output, {extension: '.html'}))
    .pipe(gulp.dest(paths.output));
});

gulp.task('build', function(callback) {
  return runSequence(
    'clean',
    'expand-tsconfig-globs',
    ['build-system', 'build-html'],
    callback
  );
});

gulp.task('default', ['build']);