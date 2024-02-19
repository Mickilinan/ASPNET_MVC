const toggleMenu = () => {
    document.getElementById('menu').classList.toggle('hide');
    document.getElementByClassName('account-buttons').classList.toggle('hide');
}

const checkScreenSize = () => {
    if (window.innerWidth >= 1200) {
        document.getElementById('menu').classList.remove('hide');
        document.getElementByClassName('account-buttons').classList.remove('hide');
    } else {
        if (!document.getElementById('menu').classList.contains('hide')) {
            document.getElementById('menu').classList.add('hide');
        }
        if (!document.getElementByClassName('account-buttons').classList.contains('hide')) {
            document.getElementByClassName('account-buttons').classList.add('hide');
        }
    }
};

window.addEventListener('resize', checkScreenSize);
checkScreenSize();