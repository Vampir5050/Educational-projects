// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('[data-open-modal]').click(async function () {
    event.preventDefault();
    console.log('daa');

    let url = $(this).attr('href');
    let response = await fetch(url);
    let result = await response.text();

    console.log(result);
    //  result+='<h1>Farid</h1>'
    $('.modal-body').html(result);

    console.log(url);

    $('#exampleModal').modal('show');
});


//$('img').on('error', function () {
//    $(this).attr('src', '/images/placeholder.png');
//})





let page;
let totalPages;
let url;


function initPagination(p, t, u) {
    page = p;
    totalPages = t;
    url = u;
}


//$('#buttonNext').click(async function () {
//    page++;

//    let response = await fetch(`${url}&page=${page}`);
//    let result = await response.text();


//    $('.row').append(result);

//    if (page == totalPages) {
//        $(this).remove();
//    }
//});

let isScroll = true;

$(window).scroll(async function () {

    if ($(window).scrollTop() + $(window).height() > $(document).height() - 100 && isScroll)
    {
        isScroll = false;

        console.log(page);
        if (page < totalPages)
        {
            page++;
            let response = await fetch(`${url}&page=${page}`);
            let result = await response.text();


            $('.row').append(result);
        }

        if (page >= totalPages) {
            $('#buttonNext').remove();
        }



        isScroll = true;
    }
});