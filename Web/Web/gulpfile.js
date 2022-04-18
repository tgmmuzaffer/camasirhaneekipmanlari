// function defaultTask(cb) {
//     // place code for your default task here
//     cb();
//   }
  
//   exports.default = defaultTask


// const { src } = require('gulp');
const gulp = require('gulp');
// const imagemin = require('gulp-imagemin');
const concat = require('gulp-concat');
const terser = require('gulp-terser');
const sourcemaps = require('gulp-sourcemaps');
const {src, series, parralel, dest, watch} = require('gulp');

// function imgTask(){
//   return src('Web/wwwroot/*').pipe(imagemin()).pipe(gulp.dest('Web/wwwroot/gulpeges'));
// }

function jsTask(){
  return src('Web/wwwroot/assets/**/*.js')
  .pipe(sourcemaps.init())
  .pipe(concat('all.js'))
  .pipe(terser())
  .pipe(sourcemaps.write('.'))
  .pipe(gulp.dest('Web/js'));
}




// exports.imgTask = imgTask;
exports.jsTask = jsTask;