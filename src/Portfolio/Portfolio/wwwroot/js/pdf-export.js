window.generatePdf = (elementId, filename) => {
    const original = document.getElementById(elementId);
    if (!original) return;

    const clone = original.cloneNode(true);

    clone.querySelectorAll('.export-ignore').forEach(el => el.remove());

    clone.classList.add('light-mode');

    clone.querySelectorAll('iconify-icon').forEach(el => {
        const iconName = el.getAttribute('icon');
        if (!iconName) return;

        const safeName = iconName.replace(/:/g, '-');
        const img = document.createElement('img');
        img.src = `icons/${safeName}.svg`;
        img.alt = iconName;
        img.width = 24;
        img.height = 24;
        img.style.verticalAlign = 'middle';
        img.className = el.className;

        el.replaceWith(img);
    });

    const opt = {
        margin: 0.5,
        filename: filename || 'documento.pdf',
        image: { type: 'jpeg', quality: 0.98 },
        html2canvas: { scale: 2 },
        jsPDF: { unit: 'in', format: 'a4', orientation: 'portrait' }
    };

    html2pdf()
        .set(opt)
        .from(clone)
        .save();
};