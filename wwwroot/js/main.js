document.addEventListener("DOMContentLoaded", function() {
    const navbar = document.querySelector(".navbar");
    
    function checkScroll() {
        let scrollTop = window.scrollY || document.documentElement.scrollTop;
        if (scrollTop > 50 || window.innerWidth <= 991) {
            navbar.classList.add("header-scrolled");
            navbar.classList.add("scrolled");
        } else {
            navbar.classList.remove("header-scrolled");
            navbar.classList.remove("scrolled");
        }
    }

    // Initial check on load
    checkScroll();

    // Check on resize and scroll
    window.addEventListener("resize", checkScroll);
    window.addEventListener("scroll", checkScroll);
});







