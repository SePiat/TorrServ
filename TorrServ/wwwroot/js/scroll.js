//var scroll_top = 0;        //высота прокрученной области
//var wind_height = $(window).height();//высота окна браузера
//var page_height = $(document).height();//высота всей страницы

//$(window).bind('scroll', function () {
//    alert("DownloadScrollstop");
//    scroll_top = $(document).scrollTop();//высота прокрученной области
//    var page_height = $(document).height();//высота всей страницы
//    wind_height = $(window).height();//высота окна браузера
//    //если непрокрученной области больше чем высота окна обраузера, то подгружаем след. объекты
//    if ((page_height - scroll_top) < wind_height * 2) {
//        var iLoad = 0;
//        while (iLoad++ < 5)
//            if (loadedRows <= tableData.length)
//                addRow(tableData[loadedRows++]);
//    }
//});
//$(document).ready(function () {
//    alert("DownloadDocReady");
//    //При открытии страницы сразу загрузим первые 30 строк (или меньше - сколько есть)      
//    for (var row1 in tableData)
//        if (loadedRows < 30 && loadedRows <= tableData.length)
//            addRow(tableData[loadedRows++]);
//        else
//            break;

//    //$(window).bind('scrollstop', function(){...

//});
//function addRow(row) {
//    //добавляем строку
//    var newRow = $("#dataTable").find('tbody').append($('<tr>'));
//    //и столбцы к ней
//    for (var td in row) {
//        $(newRow).append($('<td>').append($('<a>', {
//            href: "/images/" + row[td].f + ".jpg"
//        }).click(function () { viewgallery(row[td].i); return false; })
//            .append($('<img>', { src: "/images/small/" + row[td].f + ".jpg", alt: "..." }))));
//        // получиться <tr><td><a href="/images/123.jpg"><img src="..." alt="..."></a></td>...</tr>
//    }
//}



const moviePack = document.querySelectorAll('tr');

const options = {
    root: null,
    rootMargin: '0px',
    threshold: 0.1
}

function handleImg() {
    alert("DownloadhandleImg");
    myImg.forEach(myImgSingle => {
        console.log(myImgSingle.intersectionRatio);
        //if (myImgSingle.intersectionRatio > 0) {
        //    loadImage(myImgSingle.target);
        //}
    })
}

//function loadImage(image) {
//    image.src = image.getAttribute('data');
//}

const observer = new IntersectionObserver(handleImg, options);

moviePack.forEach(mp => {
    observer.observe(mp);
})