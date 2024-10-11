window.redirectToExternalUrl = (url, delay) => {
    setTimeout(() => window.location.href = url, delay);
};