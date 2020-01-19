<script>
  import { onMount } from 'svelte';

  let habits = [];

	onMount(async () => {
		const res = await fetch(`http://${process.env.API_URL}/habits`);
		habits = await res.json();
	});
</script>

<style>
  .habit {
    box-shadow: 0 0 2px rgba(0,0,0,0.2);
  }
</style>

<h1>Cycle</h1>

<h1>Habits</h1>

<div class="habits">
	{#each habits as habit}
    <div class="habit">
      <h3>{habit.name}</h3>
      <p>{habit.description}</p>
    </div>
	{:else}
		<p>loading...</p>
	{/each}
</div>

