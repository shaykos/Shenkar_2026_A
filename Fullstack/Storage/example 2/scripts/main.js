import { registerUser, loginUser } from './functions.js';


if (location.pathname == '/') {
    document.querySelector('#registerForm').addEventListener('submit', registerUser);
    document.querySelector('#loginForm').addEventListener('submit', loginUser);
}

if (location.pathname.includes('profile.html')) {
    let currentUser = JSON.parse(sessionStorage.getItem('currentUser'));
    if (!currentUser) {
        location.href = "/";
    }

    document.querySelector('#user_name p').textContent = currentUser.name;
    document.querySelector('#user_email p').textContent = currentUser.email;
    document.querySelector('#user_dob p').textContent = currentUser.dob;
    document.querySelector('#user_pass p').textContent = currentUser.pass;
}
