let sliderPos = 0;
let selectedReview = 0;

$(document).ready(function(){
    $('.review, .reviews__slider-bg').on("click", function() {
        if (selectedReview < 2){
            $('.review:eq('+ selectedReview +')').removeClass('reviews__selected')
            sliderPos += 238;
            selectedReview ++;
            $('.review:eq('+ selectedReview +')').addClass('reviews__selected')
            $('.reviews__slider').css('left', sliderPos + 'px');
            $('.reviews__content').css('right', selectedReview * 574 + 'px')
        }
        else {
            $('.review:eq('+ selectedReview +')').removeClass('reviews__selected')
            sliderPos = 0;
            selectedReview = 0;
            $('.review:eq('+ selectedReview +')').addClass('reviews__selected')
            $('.reviews__slider').css('left', sliderPos + 'px');
            $('.reviews__content').css('right', selectedReview * 574 + 'px')
        }
    })
})