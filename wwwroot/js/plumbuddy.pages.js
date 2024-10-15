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

window.getPreferredColorScheme = () =>
    window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches
        ? 'dark'
        : 'light';

window.redirectToExternalUrl = (url, delay) => {
    setTimeout(() => {
        try {
            window.location.href = url;
        } catch {
        }
    }, delay);
};

window.subscribeToPreferredColorSchemeChanges = dotNetObjRef =>
    window
        .matchMedia('(prefers-color-scheme: dark)')
        .addEventListener
        (
            'change',
            e => dotNetObjRef.invokeMethodAsync('UpdatePreferredColorScheme', e.matches ? 'dark' : 'light')
        );