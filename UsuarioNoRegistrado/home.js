// Obtén todos los botones con clase 'dropbtn'
const dropdowns = document.querySelectorAll('.dropdown');

// Añadir el evento de clic para mostrar/ocultar el menú desplegable
dropdowns.forEach(dropdown => {
  const button = dropdown.querySelector('.dropbtn');
  const content = dropdown.querySelector('.dropdown-content');

  button.addEventListener('click', () => {
    // Mostrar u ocultar el menú desplegable al hacer clic
    content.style.display = content.style.display === 'block' ? 'none' : 'block';
  });

  // Cerrar el menú desplegable si se hace clic fuera de él
  window.addEventListener('click', (event) => {
    if (!dropdown.contains(event.target)) {
      content.style.display = 'none';
    }
  });
});