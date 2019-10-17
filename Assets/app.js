import './app.scss';

const randomUrl = iterator =>
    `https://source.unsplash.com/random/500x300/?${iterator}`;

function loadRandomImages() {
    const images = document.querySelectorAll('img[data-random]');

    let iterator = 0;
    images.forEach(img => img.setAttribute('src', randomUrl(++iterator)));
}

document.addEventListener(
    'DOMContentLoaded',
    () => {
        loadRandomImages();
    },
    {
        passive: true,
    }
);
