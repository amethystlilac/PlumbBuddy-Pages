window.getOperatingSystem = () => {
    const userAgent = navigator.userAgent;
    if (/win/i.test(userAgent)) {
        return 'Windows';
    } else if (/mac/i.test(userAgent)) {
        return 'macOS';
    } else {
        return 'Other';
    }
};