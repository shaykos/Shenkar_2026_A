import { studentsList } from "./vars.js";
import Student from "./models/student.js"; // ייבוא ללא סוגריים מסולסלות 

export function handleStudentFormSubmit(event) {
    event.preventDefault(); // מבטל את ההתנהגות הדיפולטיבית של הטופס (רענון מחדש של הדף)

    let name = document.querySelector('#name').value;
    let age = Number(document.querySelector('#age').value);
    let gradesInput = document.querySelector('#grades').value; // "25, 30, 28"
    /*
        gradesInput.split(',') => ["25", " 30", " 28"]
        grade.trim() => "30"
        map(grade => Number(grade.trim())) => [25, 30, 28]
    */
    let grades = gradesInput.split(',').map(grade => Number(grade.trim())); // מפצל את המחרוזת למערך וממיר כל ציון למספר
    let city = document.querySelector('#city').value;
    let school = document.querySelector('#school').value;

    // יצירת אובייקט סטודנט חדש
    let s = new Student(name, age, grades, city, school);

    // הוספת הסטודנט לרשימת הסטודנטים
    studentsList.push(s);

    printStudentsList(); // הדפסת רשימת הסטודנטים 

    // איפוס הטופס לאחר ההגשה  
    event.target.reset();
}

//פונקציה להדפסת רשימת הסטודנטים
function printStudentsList() {
    let studentsListElement = document.querySelector('#studentsList'); //<ul>

    // ניקוי התוכן הקודם של הרשימה
    studentsListElement.innerHTML = '';

    // לולאה שמוסיפה כל סטודנט כרשומה חדשה ברשימה
    studentsList.forEach(student => {
        let li = document.createElement('li');
        li.textContent = `ID: ${student.id}, Name: ${student.Name}, Age: ${student.Age}, Grades: ${student.Grades.join(', ')}, City: ${student.City}, School: ${student.School}`;
        studentsListElement.appendChild(li);
    });

    // הצגת מספר הסטודנטים הכולל
    let totalStudentsElement = document.querySelector('#totalStudents');
    totalStudentsElement.textContent = `Total Students: ${Student.getTotalStudents()}`;
}
