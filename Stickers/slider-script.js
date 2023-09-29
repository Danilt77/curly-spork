let slider = document.querySelector('.slider');

document.querySelectorAll('.new-stickers__page, .new-stickers__selected-page').forEach(element => {
    element.onclick = function() {
        document.querySelector('.new-stickers__selected-page').className = 'new-stickers__page';
        element.className = 'new-stickers__selected-page';
        let pageNumber = document.querySelector('.new-stickers__selected-page').textContent.trim();;
        slider.style.right = (pageNumber - 1) * 100 + '%';
    }
});