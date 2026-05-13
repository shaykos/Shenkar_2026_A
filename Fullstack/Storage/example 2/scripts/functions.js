import User from './models/user.js';
import { users } from './vars.js';

export function registerUser(event) {
    event.preventDefault();

    let name = document.querySelector('#regName').value;
    let email = document.querySelector('#regEmail').value;
    let password = document.querySelector('#regPassword').value;
    let dob = document.querySelector('#regDob').value;

    let u = new User(name, email, dob, password);

    users.push(u);

    //שמירה של כל המשתמשים בדפדפן
    localStorage.setItem('users', JSON.stringify(users));

    alert('נרשמת בהצלחה');

    //ניקוי הטופס
    event.target.reset();
}

export function loginUser(event) {
    event.preventDefault();

    let email = document.querySelector('#loginEmail').value;
    let password = document.querySelector('#loginPassword').value;

    let currentUser = users.find((user) => user.pass == password && user.email == email);

    if (currentUser) {
        location.href = "/example 2/profile.html";
        sessionStorage.setItem('currentUser', JSON.stringify(currentUser));
    }

}