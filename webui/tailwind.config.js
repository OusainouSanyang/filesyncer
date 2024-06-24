/** @type {import('tailwindcss').Config} */
// export const content = ["./src/**/*.{html,js}"];
export const purge = ['./index.html', './src/**/*.{vue,js,ts,jsx,tsx}'];
export const darkMode = false;
export const theme = {
  extend: {},
};
export const variants = {
  extend: {},
};
export const daisyui = {
  themes: ["light", "dark", "cupcake"],
};
export const plugins = [
  require('daisyui')
];