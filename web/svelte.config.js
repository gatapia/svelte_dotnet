import adapter from '@sveltejs/adapter-static';
import autoPreprocess from 'svelte-preprocess';
import { optimizeImports } from "carbon-preprocess-svelte";

const dev = process.env.NODE_ENV === 'development';

const config = {
  preprocess: [autoPreprocess(), optimizeImports()],
  kit: {
    adapter: adapter({ fallback: 'index.html' }),
    paths: { base: dev ? '' : '/test_template' }
  }
};

export default config;
