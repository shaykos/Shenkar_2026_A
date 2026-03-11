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
