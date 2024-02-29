const toggleMenu = () => {
    document.getElementById('menu').classList.toggle('hide');
    const accountButtons = document.getElementsByClassName('account-buttons');
    for (let i = 0; i < accountButtons.length; i++) {
        accountButtons[i].classList.toggle('hide');
    }
};

const checkScreenSize = () => {
    if (window.innerWidth >= 1200) {
        document.getElementById('menu').classList.remove('hide');
        const accountButtons = document.getElementsByClassName('account-buttons');
        for (let i = 0; i < accountButtons.length; i++) {
            accountButtons[i].classList.remove('hide');
        }
    } else {
        if (!document.getElementById('menu').classList.contains('hide')) {
            document.getElementById('menu').classList.add('hide');
        }
        const accountButtons = document.getElementsByClassName('account-buttons');
        for (let i = 0; i < accountButtons.length; i++) {
            if (!accountButtons[i].classList.contains('hide')) {
                accountButtons[i].classList.add('hide');
            }
        }
    }
};

window.addEventListener('resize', checkScreenSize);
checkScreenSize();
