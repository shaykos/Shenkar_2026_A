import { matrix } from './vars.js';

export function addStudent(event) {
    //מבטל את פעולת רענון הדף בעת שליחת טופס
    event.preventDefault();

    //שליפת המידע מהטופס
    let name = document.querySelector('#name').value;
    let grade = document.querySelector('#grade').value;

    //שמירת המידע במטריצה
    //אנחנו מוסיפים לכל שורה עוד תא 
    matrix[0].push(name);
    matrix[1].push(Number(grade));

    //לרוקן את הטופס
    event.target.reset();

    //להציג את הרשימה
    showAllStudents();
}

export function showAllStudents() {
    //תופסים את האלמנט שבו רוצים להציג את הטבלה
    let content = document.querySelector('#content');
    content.innerHTML = ""; // מרוקן את ה HTML

    // אם אין מידע - נרצה להציג הודעה
    if (matrix[0].length == 0) {
        content.innerHTML = '<h2>No Students</h2>';
        return; // יציאה מהפונקציה
    }

    // יש מידע ולכן ניצור טבלה
    let table = document.createElement('table');

    //  עוברים על כל התאים ב-2 השורות במטריצה
    for (let c = 0; c < matrix[0].length; c++) {
        let name = matrix[0][c];
        let grade = matrix[1][c];

        //יוצרים שורה
        let row = document.createElement('tr');

        //יוצרים תא עבור השם ושמים בוא את ערך
        let td1 = document.createElement('td');
        td1.innerText = name;

        //יוצרים תא עבור הציו ושומרים בו את הערך
        let td2 = document.createElement('td');
        td2.innerText = grade;

        //מוסיפים לשורה את התאים
        row.appendChild(td1);
        row.appendChild(td2);

        //מוסיפים לטבלה את השורה
        table.appendChild(row);
    }

    // מוסיפים לדיב את הטבלה
    content.appendChild(table);
}   