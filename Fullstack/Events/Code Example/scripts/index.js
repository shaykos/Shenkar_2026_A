import { func1, start } from './functions.js';

// תופס את האלמנט הרצוי ושומר אותו במשתנה
// let btn = document.querySelector('#my_btn');

//משייך אירוע לחיצה לאלמנט ואת הפונקציה שצריכה לעבוד כאשר האירוע מתקיים
// btn.addEventListener('click', func1);

document.querySelector('#my_btn').addEventListener('click', func1);

document.querySelector('#guess').addEventListener('click', start);
