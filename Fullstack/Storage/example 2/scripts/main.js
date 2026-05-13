import { registerUser, loginUser } from './functions.js';


if (location.href == '/') {
    document.querySelector('#registerForm').addEventListener('submit', registerUser);
    document.querySelector('#loginForm').addEventListener('submit', loginUser);
}

if (location.href.includes('profile.html')) {
    //TODO: finish this function
}
