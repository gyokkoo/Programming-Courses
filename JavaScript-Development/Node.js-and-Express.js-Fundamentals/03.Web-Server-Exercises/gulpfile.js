var gulp = require('gulp')
var minifyHtml = require('gulp-minify-html')

gulp.task('minify-html', function () {
  gulp.src('views/*.html')
    .pipe(minifyHtml())
    .pipe(gulp.dest('minifiedHtml'))
})
