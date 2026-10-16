/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.html",
    "./**/*.razor",
    "./**/*.razor.cs",
    "./Pages/**/*.razor",
    "./Components/**/*.razor",
    "./Shared/**/*.razor"
  ],
  theme: {
    extend: {
      colors: {
        kanto: {
          // Deep Banana Leaf / Market Green (Matches inspo hero background)
          green: {
            950: '#081711',
            900: '#0F2E23',
            800: '#153D30',
            700: '#1D5241',
            600: '#2A735C',
            100: '#E4EFEA',
            50: '#F2F7F5'
          },
          // Tusok-Tusok Orange / Calamansi Sunset (Matches CTA & discount pills)
          orange: {
            600: '#CC4615',
            500: '#E75A24',
            400: '#F7703B',
            300: '#FFA07A',
            100: '#FDEEE8',
            50: '#FFF7F4'
          },
          // Soft Coconut Cream / Warm Sand Backgrounds
          cream: {
            50: '#FDFBF7',
            100: '#FAF7F2',
            200: '#F3ECE1',
            300: '#E5D8C5'
          },
          charcoal: '#1A1C1B',
          muted: '#6B7280'
        }
      },
      fontFamily: {
        sans: ['Plus Jakarta Sans', 'Inter', 'sans-serif'],
        display: ['Plus Jakarta Sans', 'sans-serif']
      },
      boxShadow: {
        'soft-card': '0 4px 20px -2px rgba(15, 46, 35, 0.06)',
        'elevated': '0 12px 32px -4px rgba(15, 46, 35, 0.12)'
      }
    },
  },
  plugins: [],
}