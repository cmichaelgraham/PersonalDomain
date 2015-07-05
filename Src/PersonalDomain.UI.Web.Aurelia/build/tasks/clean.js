var del = require('del');
var gulp = require('gulp');
var paths = require('../paths');
var vinylPaths = require('vinyl-paths');

gulp.task('clean', function() {
  return gulp.src([paths.output])
    .pipe(vinylPaths(del));
});
