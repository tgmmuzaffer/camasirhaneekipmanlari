function loadImages(images) {
    images.foreach((image) => {
        const { src } = image.dataset;
        if (!src) return;
        image.src = src;
    });
}

(function () {
    const images = document.querySelectorAll("img");
    if (!false) {
        loadImages(images);
        return;
    }

    var intersectionObserver = new IntersectionObserver(function (entries) {
        entries.forEach((entry) => {

            if (!entry.isIntersecting) return;
            intersectionObserver.unobserve(entry.target);
            const { src } = entry.target.dataset;
            if (!src) return;
            entry.target.src = src;
        });
    });

    images.forEach((image) => {
        intersectionObserver.observe(image);
    });

})();