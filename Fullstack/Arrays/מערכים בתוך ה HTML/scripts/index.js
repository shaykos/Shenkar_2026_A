/*
    יוצרים מטריצה שהשורה הראשונה שלה היא שם הסטודנט/ית 
    השורה השנייה היא ממוצע הציונים

    אנחנו נרצה לחשב בסוף את ממוצע הכיתה
*/

import { addStudent, showAllStudents } from "./functions.js";

document.querySelector('#form').addEventListener('submit', addStudent);

showAllStudents();