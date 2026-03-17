function peekPassword(inputId, btn, show) {
    var input = document.getElementById(inputId);
    if (!input) return;

    // Only switch if needed
    if (show && input.type === 'password') {
        input.type = 'text';
        btn.setAttribute('aria-pressed', 'true');
        var icon = btn.querySelector('.login-icon'); if (icon) icon.textContent = 'HIDE';
    } else if (!show && input.type === 'text') {
        input.type = 'password';
        btn.setAttribute('aria-pressed', 'false');
        var icon2 = btn.querySelector('.login-icon'); if (icon2) icon2.textContent = 'SHOW';
    }
}