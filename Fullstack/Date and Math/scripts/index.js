
let date = new Date(); // יצירת אובייקט חדש של תאריך


document.querySelector('body').innerHTML = `
    <p>הזמן שעבר מ 1.1.1970 עד עכשיו. נמדד במילי-שניות getTime() --> ${date.getTime()}</p>
    <p>כמות המילי-שניות בשעה שבה נוצר האובייקט  getMilliseconds() --> ${date.getMilliseconds()}</p>
    <p>היום בחודש getDate() --> ${date.getDate()}</p>
    <p>החודש המתאים. מתחילים תמיד ב-0 ולכן מוסיפים 1 getMonth() --> ${date.getMonth() + 1}</p>
    <p>היום בשבוע. מתחילים תמיד ב-0 ולכן מוסיפים 1 getDay() --> ${date.getDay() + 1}</p>
    <p><span>3<sup>2</sup> = </span>${Math.pow(3, 2)}</p>
    <p>|-598| = ${Math.abs(-598)}</p>
`;