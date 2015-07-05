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

gulp.task('build-system', function () {
  return gulp.src(paths.source)
    .pipe(typescript(typescript.createProject('tsconfig.json', { typescript: require('typescript') })))  
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
    ['build-system', 'build-html'],
    callback
  );
});
