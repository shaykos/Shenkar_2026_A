/*
    יוצרים מטריצה שהשורה הראשונה שלה היא שם הסטודנט/ית 
    השורה השנייה היא ממוצע הציונים

    אנחנו נרצה לחשב בסוף את ממוצע הכיתה
*/

let matrix = new Array();

let size = Number(prompt("כמה תלמידים"));

matrix[0] = new Array(size).fill(""); // שורה ראשונה - שמות הסטודנטים
matrix[1] = new Array(size).fill(0); // שורה שנייה - הציונים של כל סטודנט

for (let c = 0; c < size; c++) {
    matrix[0][c] = prompt("מה שמך?");
    matrix[1][c] = Number(prompt("ומה הממוצע שלך?"));
}

console.log(matrix);

let sum = matrix[1].reduce((prev, current) => prev + current);
console.log(`the class average is ${(sum / size).toFixed(3)}`);
