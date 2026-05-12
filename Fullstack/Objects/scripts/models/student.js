export default class Student {

    static idCounter = 1000; // משתנה סטטי לשמירת המספר הסידורי של הסטודנט הבא שיווצר  

    constructor(name, age, grades, city, school) {
        this.Name = name;
        this.Age = age;
        this.Grades = grades; // מערך של ציונים
        this.City = city;
        this.School = school;
        this.id = Student.idCounter++; // מזהה ייחודי לכל סטודנט
    }

    set Name(value) { this.name = value; }
    get Name() { return this.name; }

    set Age(value) {
        // if (typeof value != "number") {
        //     console.log("Invalid input. please enter a number!");
        //     this.age = -1;
        // }
        if (value >= 6 && value <= 18)
            this.age = value;
        else {
            console.log("Invalid input. please enter a number between 6 and 18!");
            this.age = -1;
        }
    }
    get Age() { return this.age; }

    set Grades(value) { this.grades = value; }
    get Grades() { return this.grades; }

    set City(value) { this.city = value; }
    get City() { return this.city; }

    set School(value) { this.school = value; }
    get School() { return this.school; }

    // פונקציה שמחשבת את ממוצע הציונים של הסטודנט
    // קיימת ברמה של האובייקט
    calcStudentAvgGrade() {
        // reduce - פונקציה שמקבלת פונקציה אחרת ומפעילה אותה על כל איבר במערך ומחזירה ערך מצטבר
        // acc - הערך המצטבר, grade - האיבר הנוכחי במערך
        let sum = this.Grades.reduce((acc, grade) => { return acc + grade }, 0);

        // let s = 0;
        // for (let i = 0; i < this.Grades.length; i++) {
        //     s += this.Grades[i];
        // }

        return sum / this.Grades.length;
    }

    static getTotalStudents() {
        return Student.idCounter - 1000; // מחזיר את מספר הסטודנטים שנוצרו עד כה;
    }
}