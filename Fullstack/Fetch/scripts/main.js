import {fetchCities, fetchCities2} from './functions.js';

document.querySelector('#fetch-btn').addEventListener('click', fetchCities);

document.querySelector('#autocomplete-input').addEventListener('input', fetchCities2);