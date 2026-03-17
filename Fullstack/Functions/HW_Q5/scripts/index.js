import { startGame } from "./functions.js";

const max = 1000, min = 0;

let num = Math.floor(Math.random() * (max - min) + min);
let guessCount = 0;
let guess = Number(prompt("מה הניחוש שלך? "));

startGame(num, guess, guessCount);