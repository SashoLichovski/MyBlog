let galleryImgs = document.getElementsByClassName(`galleryImgs`);
function ChangeImage(event, mathSign) {
    console.log(event.target.id);
    let img = document.getElementById(`image-${event.target.id}`);
    for (var i = 0; i < galleryImgs.length; i++) {
        if (img.src === galleryImgs[i].src) {
            var no;
            mathSign == "+" ? no = i + 1 : no = i - 1;
            img.src = galleryImgs[no].src;
            break;
        }
    }
}

