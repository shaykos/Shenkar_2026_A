import { num } from './vars.js';

export function func1() {
    alert("איה!!!! זה כואב!!");
}

export function start() {
    let msg = document.querySelector('#msg');
    let input = document.querySelector('#userGuess');
    let guess = Number(input.value); // המספר שהמשתמש כתב בשדה 
    if (guess > num) {
        msg.innerHTML = 'המספר שבחרת גבוה מהמספר שהוגרל';
    }
    else if(guess < num) {
        msg.innerHTML = 'המספר שבחרת נמוך מהמספר שהוגרל';
    }
    else{
        msg.innerHTML = 'כל הכבוד! הצלחת לנחש את המספר';
    }
};