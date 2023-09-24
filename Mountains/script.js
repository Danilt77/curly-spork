document.getElementsByClassName('nav__open-btn')[0].onclick = function(event) {
    document.getElementsByClassName('nav__menu-opened')[0].style.left = 0;
    document.getElementsByClassName('nav__close')[0].style.display = 'block';
}

document.getElementsByClassName('nav__close')[0].onclick = function(event) {
    document.getElementsByClassName('nav__menu-opened')[0].style.left = '100%';
}


// First we get the viewport height and we multiple it by 1% to get a value for a vh unit
let vh = window.innerHeight * 0.01;
// Then we set the value in the --vh custom property to the root of the document
document.documentElement.style.setProperty('--vh', `${vh}px`);

// слушаем событие resize
window.addEventListener('resize', () => {
    // получаем текущее значение высоты
    let vh = window.innerHeight * 0.01;
    document.documentElement.style.setProperty('--vh', `${vh}px`);
  });