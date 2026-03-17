export function startGame(num, guess, guessCount) {

    while (num != guess) {
        guessCount++;
        if(num < guess)
            alert("המספר שבחרתי נמוך מהניחוש שלך");
        else 
            alert("המספר שבחרתי גבוה מהמספר שלך");

        guess = Number(prompt("מה הניחוש הבא שלך?"));
    }

    alert(`כל הכבוד! הצלחת לנחש את המספר שבחרתי לאחר ${guessCount} נסיונות`);

}