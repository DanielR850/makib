const dropdowns = document.querySelectorAll('.dropdown');

dropdowns.forEach(dropdown => {
  const button = dropdown.querySelector('.dropbtn');
  const content = dropdown.querySelector('.dropdown-content');

  button.addEventListener('click', () => {
    content.style.display = content.style.display === 'block' ? 'none' : 'block';
  });

  window.addEventListener('click', (event) => {
    if (!dropdown.contains(event.target)) {
      content.style.display = 'none';
    }
  });
});

document.getElementById('back-button').addEventListener('click', function() {
  location.href = 'Home.html'; 
});