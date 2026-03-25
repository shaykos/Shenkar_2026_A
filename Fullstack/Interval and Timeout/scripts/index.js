/**
 * setTimeout - מבצע פונקציה פעם אחת לאחר זמן מסוים (במילישניות)
 * דוגמה: setTimeout(() => console.log('Hello'), 1000) - ידפיס 'Hello' אחרי שנייה אחת
 * 
 * setInterval - מבצע פונקציה שוב ושוב כל X זמן (במילישניות)
 * דוגמה: setInterval(() => console.log('Hello'), 1000) - ידפיס 'Hello' כל שנייה, לנצח
 * 
 * ההבדל העיקרי: setTimeout רץ פעם אחת, setInterval רץ באופן חוזר
 */

import { updateElement } from './functions.js';
let c = 0;

updateElement('#stam', '<p>kuku kuku kuku kuku</p>');


setTimeout(() => {
    let date = new Date();
    updateElement('#timeout', date.toLocaleString());
}, 5000);


let interval1 = setInterval(() => {
    c++;
    updateElement('#interval', c);
    if (c == 10)
        clearInterval(interval1);
}, 1000);