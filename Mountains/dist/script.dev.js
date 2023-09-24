"use strict";

document.getElementsByClassName('nav__open-btn')[0].onclick = function (event) {
  document.getElementsByClassName('nav__menu-opened')[0].style.left = 0;
  document.getElementsByClassName('nav__close')[0].style.display = 'block';
};

document.getElementsByClassName('nav__close')[0].onclick = function (event) {
  document.getElementsByClassName('nav__menu-opened')[0].style.left = '100%';
};