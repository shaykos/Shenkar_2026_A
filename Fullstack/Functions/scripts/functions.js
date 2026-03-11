//alert ומציגה אותו ב msg הפונקציה מקבלת פרמטר בשם 
//מאפשרת לנו לייצא את הפונקציה ולהשתמש בה בקובץ אחר export המילה השמורה 
export function showAlert(msg) {
    if (msg != undefined)
        alert(`your massage: ${msg}`);
    else
        console.error("you didn't provide any message");
}

// בפונקציה הזו יש ערך ברירת מחדל לפרמטר שמתקבל אם לא שולחים מידע
// במידה ושלחתי פרמטר ערך ברירת המחדל נדרס
export function showAlert2(msg = "Hello World") {
    alert(`your massage: ${msg}`);
}

// פונקציה המקבלת 4 מספרים ומחזירה את הממוצע
export function CalcAverage(n1, n2, n3, n4) {
    let avg = (n1 + n2 + n3 + n4) / 4;
    return avg;
}

//שנשלח limit פונקציה המדפיסה את לוח הכפל בהתאם לפרמטר 
// כברירת מחדל היא תדפיס את לוח הכפל של 10
export function PrintMultiTable(limit = 10) {

    // שלב 1 - תופסים את האלמנט בו יוצג לוח הכפל
    let div = document.querySelector('#answer');

    // שלב 2 - מתחילים ליצור את התבנית של לוח הכפל
    let table = '<table>';

    // שלב 3 - למלא את לוח הכפל
    for (let row = 1; row <= limit; row++) {
        // שלב 3.1 - יצירת שורה 
        table += '<tr>';

        // שלב 3.2 - יוצרים את התאים בכל שורה
        for (let col = 1; col <= limit; col++) {
            table += `<td>${row * col}</td>`;
        }

        // שלב 3.3 - סוגרים את השורה
        table += '</tr>';
    }

    // שלב 3.4 - סוגרים את הטבלה
    table += '</table>';

    // div שלב 4 - הזרקת הטבלה לתוך ה 
    div.innerHTML += table;
}
