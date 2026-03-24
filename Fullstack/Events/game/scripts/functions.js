
export function movePlayer(event) {
    let player = document.querySelector('#player');
    let box = document.querySelector('#box');
    let boxLeft = Number(getComputedStyle(box).left.replace('px', ''));
    let playerWidth, positionLeft, positionTop;
    switch (event.key) {
        case 'd':
            playerWidth = Number(getComputedStyle(player).width.replace('px', ''));;
            positionLeft = Number(getComputedStyle(player).left.replace('px', ''));
            positionLeft += 15;
            if (positionLeft + playerWidth < boxLeft)
                player.style.left = `${positionLeft}px`;
            else
                alert('Ouch!')
            break;
        case 'a':
            positionLeft = Number(getComputedStyle(player).left.replace('px', ''));
            positionLeft -= 15;
            if (positionLeft > 0)
                player.style.left = `${positionLeft}px`;
            break;
        case 'w':
            positionTop = Number(getComputedStyle(player).top.replace('px', ''));
            let maxJump = 50;
            let jumpHeight = 0;
            let interval = setInterval(() => {
                jumpHeight += 2;
                positionTop -= 2;
                player.style.top = `${positionTop}px`;
                if (jumpHeight >= maxJump) {
                    clearInterval(interval);
                    positionTop += maxJump;
                    player.style.top = `${positionTop}px`;
                }
            }, 20);

            break;
    }
}


